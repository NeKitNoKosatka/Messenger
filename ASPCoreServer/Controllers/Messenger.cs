using Messenger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Messenger : ControllerBase
    {

        static List<Message> ListOfMessages = new List<Message>();

        private static bool clean_status = false;

        // GET api/<Messenger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not found";

            //if (IsClear())
            //{
            //    Console.WriteLine("сервер пуст");
            //    OutputString = "Server is clear";
            //    return OutputString;
            //}

            if ((id < ListOfMessages.Count) && (id >= 0))        //&& (id != 5))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
            }
            
            Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST api/<Messenger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                Console.WriteLine("message doesn't sent");
                //return BadRequest();
            }

            

            if (ListOfMessages.Count == 30 && clean_status != true) //30
            {
                clean_status = true;
                Console.WriteLine("Cleaning server");

                DB db = new DB();

                string query = $"INSERT INTO db.content(`content_id`, `content`) VALUES(NULL, @content); INSERT INTO db.`message` (`message_id`, `chat_id`, `sender_id`, `content_id`, `send_date`) VALUES(NULL, @chat_id, @sender_id, (SELECT @@IDENTITY), @send_date);";
                

                int counter = 0;
                foreach (Message message in ListOfMessages)
                {
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.Add("@content", MySqlDbType.VarChar).Value = message.MessageText;
                    command.Parameters.Add("@chat_id", MySqlDbType.VarChar).Value = message.ChatID;
                    command.Parameters.Add("@sender_id", MySqlDbType.VarChar).Value = message.UserID;

                    int x = message.TimeStamp.ToString("u").Length - 1;
                    var date = message.TimeStamp.ToString("u").Remove(x);
                    command.Parameters.Add("@send_date", MySqlDbType.VarChar).Value = date;
                    
                    //Console.WriteLine(message.ChatID);

                    db.OpenConnection();
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();

                    counter++;
                    Console.WriteLine("Message №" + counter + " sent to db");
                    //while (reader.Read())
                    //{
                    //    counter++;
                    //    Console.WriteLine("Message №" + counter + "sent to db");
                    //}

                    reader.Close();
                    db.CloseConnection();

                    clean_status = false;
                }

                ListOfMessages.Clear();
                //return new OkResult();
            }

            if (msg.UserID == 0 || msg.ChatID == -1)
                return new OkResult();
            else
            {
                ListOfMessages.Add(msg);
                Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListOfMessages.Count, msg));
                //return new NoContentResult();
            }

            return new OkResult();
        }


        static private bool IsCleaning()
        {
            if (ListOfMessages.Count == 0)
                return true;
            else
                return false;
        }


        static private bool IsClear()
        {
            if (ListOfMessages.Count == 0)
                return true;
            else
                return false;
        }

    }
}
