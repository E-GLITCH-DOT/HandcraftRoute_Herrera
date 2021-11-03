using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Handcraft_RouteApp.Domain.Entities
{
        public class Users
        {
            public int Id{get;set;}
            
            public string UserName{get;set;}

            public string Password{get;set;}

            public string Rol{get;set;}
        }
}