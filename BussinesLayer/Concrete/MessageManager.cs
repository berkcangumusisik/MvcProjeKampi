using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message message)
        {
            _messageDal.Delete(message);
        }

        public List<Message> GetAllRead()
        {
            return _messageDal.List(m => m.ReceiverMail == "admin@gail.com").Where(m => m.IsRead == false).ToList();
        }

        public Message GetById(int Id)
        {
            return _messageDal.Get(m => m.MessageId == Id);
        }

        public List<Message> GetMessageSendBox()
        {
            return _messageDal.List(m => m.SenderMail == "gumusisikberkcan@gmail.com");
        }

        public List<Message> GetMessagesInbox()
        {
            return _messageDal.List(m => m.ReceiverMail == "gumusisikberkcan@gmail.com");
        }

        public void Insert(Message message)
        {
            _messageDal.Insert(message);
        }

        public List<Message> IsDraft()
        {
            return _messageDal.List(m => m.IsDraft == true);
        }

        public void Update(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
