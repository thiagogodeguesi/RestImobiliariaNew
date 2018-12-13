using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestImobiliaria.Models;

namespace RestImobiliaria.Controllers
{
    [RoutePrefix("api/imobiliaria")]
    public class ImobiliariaController : ApiController
    {
        /// <summary>
        /// *************************
        /// **** INICIO CORRETOR ****
        /// *************************
        /// </summary>

        private static Corretor nCorretor = new Corretor();

        [AcceptVerbs("POST")]
        [Route("CadCorretor")]
        public string CadastroCorretor(Corretor xCorretor)
        {
            int vRet = 0;
            vRet = nCorretor.NovoCorretor(xCorretor);

                return "Usuário cadastrado com sucesso!" + vRet;
        }

        [AcceptVerbs("GET")]
        [Route("FullCorretor")]
        public List<Corretor> retCorretor()
        {
            List<Corretor> listCorretores = new Corretor().listaCorretores();
            return listCorretores;
        }

        [AcceptVerbs("GET")]
        [Route("IdCorretor/{id}")]
        public Corretor retCorretorId(int id)
        {
            Corretor oCorretor = new Corretor().oCorretor(id);
            return oCorretor;
        }

        [AcceptVerbs("POST")]
        [Route("AltCorretor")]
        public string AlteraCorretor(int xID, Corretor xCorretor)
        {
            int vRet = 0;
            vRet = nCorretor.AlteraCorretor(xID, xCorretor);

            return "Usuário cadastrado com sucesso!" + vRet;
        }

        /// <summary>
        /// **********************
        /// **** FIM CORRETOR ****
        /// **********************
        /// </summary>

        /// <summary>
        /// ***********************
        /// **** INICIO IMOVEL ****
        /// ***********************
        /// </summary>



        /// <summary>
        /// ********************
        /// **** FIM IMOVEL ****
        /// ********************
        /// </summary>

        /// <summary>
        /// ************************
        /// **** INICIO CLIENTE ****
        /// ************************
        /// </summary>



        /// <summary>
        /// *********************
        /// **** FIM CLIENTE ****
        /// *********************
        /// </summary>

    }
}
