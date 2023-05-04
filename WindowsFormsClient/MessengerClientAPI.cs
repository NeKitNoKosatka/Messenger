using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    class MessengerClientAPI
    {
        private static readonly HttpClient client = new HttpClient();
        // тестовое сообщение в формате JSON
        Message server_clear_msg = new Message("Admin", "Server is clear", DateTime.UtcNow, 0, 0, 0);
        public void TestNewtonsoftJson()
        {
            // Тест JSon SerializeObject NewtonSoft
            Message msg = new Message("Nik", "Hi u Hi", DateTime.UtcNow, 0, 1, 2);
            
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserializedMsg);
            //string path = @"d:\temp\ser.txt";
            //using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            //{
            //  sw.WriteLine(output);
            //}
        }
        
        // получение сообщение
        public Message GetMessage(int MessageId)
        {
            //if (MessageId == 10)
            //{
            //    Console.WriteLine("null");
            //    return null;
            //}

            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messenger/" + MessageId.ToString());
            request.Method = "Get";
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            //Console.WriteLine(status);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //Console.WriteLine(responseFromServer);
            reader.Close();
            dataStream.Close();
            response.Close();
            if ((status.ToLower() == "ok") && (responseFromServer != "Not found")) //&& (responseFromServer != "Server is clear"))
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseFromServer);
                //Console.WriteLine(deserializedMsg);
                //Console.WriteLine(responseFromServer);
                return deserializedMsg;
            }
            //else if (responseFromServer == "Server is clear")
            //{
            //    Console.WriteLine("сервер пуст");
            //    return server_clear_msg;
            //}
            return null;
        }

        // асинхронное получение сообщения
        public async Task<Message> GetMessageHTTPAsync(int MessageId) 
        {

            var responseString = await client.GetStringAsync("http://localhost:5000/api/Messenger/" + MessageId.ToString());
            if (responseString != null)
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseString);
                return deserializedMsg;
            }
            return null;
        }

        // отправка сообщения
        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messenger");
            request.Method = "POST";
            //Message msg = new Message("Nik", "Privet", DateTime.Now);
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //Console.WriteLine(responseFromServer);
            reader.Close();
            dataStream.Close();
            response.Close();
            return true;
        }
    }
}
