using HttpMultipartParser;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qliqCloudApiCSharpSample
{
    public partial class Form1 : Form
    {
        private SimpleHTTPServer myServer;
        private string privateKeyFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onHttpRequest(HttpListenerContext context)
        {
            var request = context.Request;

            LogRequestText(string.Format("{0} New HTTP request\r\n", DateTime.Now));

            string requestFileName = string.Format(@"c:\http_request_{0}.txt", DateTime.Now.Ticks);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(requestFileName))
            {
                file.Write("{0} {1}\n", request.HttpMethod, request.Url.ToString());
                LogRequestText(string.Format("{0} {1}\r\n", request.HttpMethod, request.Url.ToString()));

                foreach (string key in request.Headers.AllKeys)
                {
                    string[] values = request.Headers.GetValues(key);
                    if (values.Length > 0)
                    {
                        file.Write("{0}:", key);
                        foreach (string value in values)
                        {
                            file.Write(" {0}", value);
                            LogRequestText(string.Format("{0}: {1}\r\n", key, value));
                        }
                        file.Write("\n");
                    }
                }

                if (!request.HasEntityBody)
                {
                    LogErrorTextLine("No client data was sent with the request.");
                    return;
                }

                System.IO.Stream body = request.InputStream;
                System.Text.Encoding encoding = request.ContentEncoding;
                System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);

                // Convert the data to a string and display it on the console.
                string s = reader.ReadToEnd();
                body.Close();
                reader.Close();

                file.WriteLine("");
                file.Write(s);
                LogRequestTextLine(s);

                if (request.ContentType.StartsWith("multipart/form-data"))
                {
                    string boundary = null;
                    foreach (Match match in Regex.Matches(request.ContentType, "; boundary=(.+)"))
                    {
                        boundary = match.Groups[1].Value;
                        break;
                    }

                    using (Stream stream = ToStream(s))
                    {
                        bool messageFound = false;
                        var parser = new MultipartFormDataParser(stream, boundary, encoding);
                        foreach (FilePart fp in parser.Files)
                        {
                            if (fp.Name == "message")
                            {
                                messageFound = true;

                                System.IO.StreamReader dataReader = new System.IO.StreamReader(fp.Data);
                                string message = dataReader.ReadToEnd();
                                dataReader.Close();

                                if (message == null || message.Length == 0)
                                {
                                    LogErrorTextLine("The 'message' part is empty");
                                }
                                else
                                {
                                    LogReplyText(string.Format("{0} New reply:\r\n", DateTime.Now));

                                    string decrypted = Crypto.decryptFromBase64WithKeyFile(message, privateKeyFileName);
                                    if (decrypted == null || decrypted.Length == 0)
                                    {
                                        LogErrorTextLine("Cannot decrypt the message");
                                    }
                                    else
                                    {
                                        LogReplyTextLine(decrypted);
                                    }
                                }
                            }
                        }

                        if (!messageFound)
                        {
                            LogErrorTextLine("No 'message' found in form data");
                        }
                    }
                }
                else
                {
                    LogErrorTextLine("Unexpected Content-Type: " + request.ContentType);
                }

                file.Close();
            }

            context.Response.StatusCode = (int)HttpStatusCode.OK;
            context.Response.OutputStream.Close();
        }

        private void TestHttpServer()
        {
            if (startStopButton.Text.StartsWith("Start"))
            {
                if (privateKeyFileName == null)
                {
                    MessageBox.Show("You must specifiy a private key file before starting the server");
                    return;
                }

                try
                {
                    string myFolder = @"C:\";
                    myServer = new SimpleHTTPServer(myFolder, Decimal.ToInt32(httpPortUpDown.Value));
                    myServer.addUrlDelegate("receive", onHttpRequest);
                    if (!myServer.WaitForServerToListen())
                    {
                        string message = myServer.LastException.Message;
                        if (message == "Access is denied")
                        {
                            message += string.Format("\r\n\r\nRun this application as Administrator or execute the following command:\r\nnetsh http add urlacl url=http://*:{0}/ user=Everyone listen=yes", Decimal.ToInt32(httpPortUpDown.Value));
                        }
                        MessageBox.Show("Cannot start server:\n" + message, "qliq", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        startStopButton.Text = "Stop HTTP Server";
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
            else
            {
                myServer.Stop();
                startStopButton.Text = "Start HTTP Server";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestHttpServer();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (myServer != null)
            {
                myServer.Stop();
            }
        }

        private void LogRequestText(string str)
        {
            this.Invoke((MethodInvoker)delegate {
                requestsTextBox.Text += str; // runs on UI thread
            });
        }

        private void LogRequestTextLine(string str)
        {
            LogRequestText(str + "\r\n");
        }

        private void LogReplyText(string str)
        {
            this.Invoke((MethodInvoker)delegate {
                repliesTextBox.Text += str; // runs on UI thread
            });
        }

        private void LogReplyTextLine(string str)
        {
            LogReplyText(str + "\r\n");
        }

        private void LogErrorTextLine(string str)
        {
            this.Invoke((MethodInvoker)delegate {
                errorsTextBox.Text += string.Format("{0}: {1}\r\n", DateTime.Now, str); // runs on UI thread
            });
        }

        public static Stream ToStream(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private void browserPrivateKeyFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM Files|*.pem";
            openFileDialog.Title = "Select a Private Key PEM File";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                if (!Crypto.canLoadPrivateKey(fileName))
                {
                    MessageBox.Show("Cannot open the private key");
                    privateKeyFileTextBox.Text = "";
                    privateKeyFileName = null;
                }
                else
                {
                    privateKeyFileTextBox.Text = fileName;
                    privateKeyFileName = fileName;
                }
            }
        }
    }
}
