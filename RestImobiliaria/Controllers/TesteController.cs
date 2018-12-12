using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestImobiliaria.Models;

namespace RestImobiliaria.Controllers
{
    public class TesteController : ApiController
    {
        // GET: api/Teste
        /*
        public IEnumerable<Testeinfo> Get()
        {
            var testeinfList = new List<Testeinfo>();
            for (int i = 0; i < 10; i++)
            {
                var testeinfo = new Testeinfo
                {
                    Id = i, Valor = "Teste UOL - " + i
                };
                testeinfList.Add(testeinfo);
            }
            return testeinfList;
        }
        */
        // GET: api/Teste/5
        public Testeinfo Get(int id)
        {
            return new Testeinfo
            {
                Id = id,
                Valor = "Teste - " + id
            };
        }

        // GET: api/Vai/5
        public IEnumerable<Corretor> Get()
        {
            var listCorretor = new List<Corretor>();
            //----
            for (int i = 0; i < 10; i++)
            {
                var xCorretor = new Corretor
                {
                    Id = i
                    , Nome = "João " + i
                    , Cpf = "Cpf - " + i
                    , Creci = i.ToString()
                    , Email = i.ToString() + "@" + i.ToString()
                    , Senha= i.ToString()+ i.ToString()+ i.ToString()+ i.ToString()
                    , Telefone= i.ToString()+ i.ToString()
                    , Ufcreci= i.ToString()+ i.ToString()
                    , Visivel=0
                };
                listCorretor.Add(xCorretor);
            }
            //----
            return listCorretor;
        }

        //push 
        public void Put(int id, [FromBody]string value)
        {
            var listCorretor = new List<Corretor>();
            //----
            for (int i = 0; i < 10; i++)
            {
                var xCorretor = new Corretor
                {
                    Id = id
                    ,
                    Nome = value
                };
                listCorretor.Add(xCorretor);
            }
        }
        /*
        // GET: Teste/6
        public Tes  Get(int id)
        {
            return new Testeinfo
            {
                Id = id,
                Valor = "Teste - " + id
            };
        }
        */
    }
}
