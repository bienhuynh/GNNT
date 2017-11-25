﻿using GNNT.Bot.Server.Data;
using GNNT.Bot.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GNNT.Bot.Server.API.Controllers
{
    public class AskPlacesController : ApiController
    {
        private string photoBot;
        private DataPlaces dataPlacesService = new DataPlaces();
        private List<MPlace> dataPlaces = new List<MPlace>();

        public AskPlacesController()
        {
            photoBot = "https://media.wired.com/photos/592d06185fd65b767a6f2dfa/master/w_799,c_limit/chat_bot-01-green.jpg";
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "Binh duong", "ca mau" };
        }

        [HttpGet]
        [Route("api/AskPlaces/ReplyMessage/{message}")]
        public List<Answer> Reply(string message)
        {
            //message = "Biết AEON MALL Bình Dương Canary không ?";
            dataPlaces = dataPlacesService.ReturnData();
            string URL = "https://fifo-88857.firebaseio.com/messages/.json";
            BotService.BotWithDatabase bot = new BotService.BotWithDatabase(URL);
            //bot.BotSendMessageText(new Models.MessageText { name = "bot", message = message, photoUrl = photoBot });
            foreach (MPlace item in dataPlaces)
            {
                foreach (Ask i in item.askList)
                {
                    if (i.Text == message)
                    {
                        List<Models.MessageText> listMessage = new List<Models.MessageText>();
                        foreach (Answer anwser in item.answerlist)
                        {
                            listMessage.Add(new Models.MessageText { name = "Bot", message = anwser.Text, photoUrl = photoBot });
                        }
                        bot.BotSendListMessageText(listMessage);
                        return item.answerlist;
                    }
                }
            }
            bot.BotSendListMessageText
                (
                    new List<Models.MessageText>
                    {
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "bot not understand!" },
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "I'm Sorry!" }
                    }
                );
            return null;
        }

        [HttpPost]
        [Route("api/AskPlaces/Reply")]
        public List<Answer> Post()
        {
            string message = "Hello";
            dataPlaces = dataPlacesService.ReturnData();
            string URL = "https://fifo-88857.firebaseio.com/messages/.json";
            BotService.BotWithDatabase bot = new BotService.BotWithDatabase(URL);

            foreach (MPlace item in dataPlaces)
            {
                foreach (Ask i in item.askList)
                {
                    if (i.Text == message)
                    {
                        List<Models.MessageText> listMessage = new List<Models.MessageText>();
                        foreach (Answer anwser in item.answerlist)
                        {
                            listMessage.Add(new Models.MessageText { name = "Bot", message = anwser.Text, photoUrl = photoBot });
                        }
                        bot.BotSendListMessageText(listMessage);
                        return item.answerlist;
                    }
                }
            }
            bot.BotSendListMessageText
                (
                    new List<Models.MessageText>
                    {
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "bot not understand!" },
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "I'm Sorry!" }
                    }
                );
            return null;
        }
        // POST api/<controller>
        [HttpPost]
        [Route("api/AskPlaces/Reply")]
        public List<Answer> Post(string message)
        {
            dataPlaces = dataPlacesService.ReturnData();
            string URL = "https://fifo-88857.firebaseio.com/messages/.json";
            BotService.BotWithDatabase bot = new BotService.BotWithDatabase(URL);

            foreach (MPlace item in dataPlaces)
            {
                foreach (Ask i in item.askList)
                {
                    if (i.Text == message)
                    {
                        List<Models.MessageText> listMessage = new List<Models.MessageText>();
                        foreach (Answer anwser in item.answerlist)
                        {
                            listMessage.Add(new Models.MessageText { name = "Bot", message = anwser.Text, photoUrl = photoBot });
                        }
                        bot.BotSendListMessageText(listMessage);
                        return item.answerlist;
                    }
                }
            }
            bot.BotSendListMessageText
                (
                    new List<Models.MessageText>
                    {
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "bot not understand!" },
                        new Models.MessageText { name = "bot", photoUrl = photoBot, message = "I'm Sorry!" }
                    }
                );
            return null;
        }
    }
}
