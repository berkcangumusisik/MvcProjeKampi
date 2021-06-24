using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BussinesLayer.Abstract
{
    public interface IMessageService
    {
        void Insert(Message message);
        List<Message> GetMessagesInbox();
        List<Message> GetMessagesInbox(string receiver);
        List<Message> GetMessageSendBox(string sender);
        void Delete(Message message);
        void Update(Message message);
        Message GetById(int Id);
        List<Message> GetMessageSendBox();
        List<Message> GetAllRead();
        List<Message> IsDraft();

    }
}
