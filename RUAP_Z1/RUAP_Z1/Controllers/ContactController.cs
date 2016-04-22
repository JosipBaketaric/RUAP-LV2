using RUAP_Z1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RUAP_Z1.Services;

namespace RUAP_Z1.Controllers
{
    public class ContactController : ApiController
    {
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }


    }
}
