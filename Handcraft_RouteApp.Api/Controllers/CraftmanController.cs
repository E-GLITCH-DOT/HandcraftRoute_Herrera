
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using Handcraft_RouteApp.Domain.Entities;
using Handcraft_RouteApp.Domain.Datos;
using Handcraft_RouteApp.Infrastructure.Repositories;


namespace Handcraft_RouteApp.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CraftmanController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            var repository = new CraftmanSqlRepository();
            var craftmans = repository.GetAll();
            var respuestaC = craftmans.Select(ct => CreateDtoFromObject(ct));
            return Ok(respuestaC);
        } 

        [HttpGet]
        [Route("Name/{firstName}")]
        public IActionResult GetByName(string firstName)
        {
            var repository = new CraftmanSqlRepository();
            var craftmans = repository.GetByName(firstName);
            return Ok(craftmans);
        }


        [HttpGet]
        [Route("lastname/{lastName}")]
        public IActionResult GetByLastName(string lastName)
        {
            var repository = new CraftmanSqlRepository();
            var craftmans = repository.GetByLastName(lastName);
            return Ok(craftmans);
        }

        [HttpGet]
        [Route("gender/{gender}")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new CraftmanSqlRepository();
            var craftmans = repository.GetByGender(gender);
            return Ok(craftmans);
        }


        private CraftmanResponse CreateDtoFromObject(Craftman craftmans){
            var dtos = new CraftmanResponse(
                Name : $"{craftmans.FirstName} {craftmans.LastName}",
                Gender : craftmans.Gender,
                Telephone : craftmans.Telephone,
                Email : craftmans.Email,
                Age : craftmans.age
            );
            return dtos;
        }



        #region"Request"
        private Craftman CreateObjectFromDto(CraftmanRequest dto){
            var craftman = new Craftman{
                IdCraftman = 0,
                FirstName = string.Empty,
                LastName = string.Empty,
                Gender = dto.Gender.Value,
                Birthday = dto.Birthday.Date,
                Address = new Address
                {
                    Street = string.Empty,
                    Number = string.Empty,
                    City = string.Empty
                },
                MunicipalityNavigation = new Municipality{
                    NameMunicp = string.Empty
                },
                Telephone = string.Empty,
                Email = string.Empty,
                SocialNetworksNavigation = new SocialNetwork{
                    Link = string.Empty
                },
                AssociationNavigation = new Association{
                    Name = string.Empty
                },
                Logo = string.Empty,
               
            };

            return craftman;
        }
        #endregion
    }
}