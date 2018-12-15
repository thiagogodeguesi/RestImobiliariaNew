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
            if (xCorretor != null)
            {
                vRet = nCorretor.NovoCorretor(xCorretor);
                if (vRet != 0)
                {
                    return "Corretor cadastrado com sucesso!" + vRet;
                }
            }
            return "Corretor NÃO cadastrado!" + vRet;
        }
        
        [AcceptVerbs("GET")]
        [Route("FullCorretor")]
        public List<Corretor> retCorretor()
        {
            List<Corretor> listCorretores = new Corretor().listaCorretores();
            return listCorretores;
        }
        [AcceptVerbs("GET")]
        [Route("loginUser")]
        public bool retCorretorId(string email, string senha)
        {
            Corretor RoCorretor = new Corretor();
            bool xcont = new Corretor().loginCorretor(email, senha, out RoCorretor);

            return xcont;
        }

        [AcceptVerbs("GET")]
        [Route("IdCorretor/{id}")]
        public Corretor retCorretorId(int id)
        {
            Corretor oCorretor = new Corretor().oCorretor(id);
            return oCorretor;
        }
        
        [AcceptVerbs("PUT")]
        [Route("AltCorretor")]
        public string AlteraCorretor(int xID, Corretor xCorretor)
        {
            int vRet = 0;
            if (xCorretor != null)
            {
                vRet = nCorretor.AlteraCorretor(xID, xCorretor);
                if (vRet != 0)
                {
                    return "Corretor alterado com sucesso!" + vRet;
                }
            }
            return "Corretor NÃO alterado!" + vRet;
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
        [AcceptVerbs("POST")]
        [Route("CadImovel")]
        public string CadastroImovel(Imovel xImovel)
        {
            int vRet = 0;
            if (xImovel != null)
            {
                //vRet = nCorretor.NovoCorretor(xCorretor);
                if (vRet != 0)
                {
                    return "Imóvel cadastrado com sucesso!" + vRet;
                }
            }
            return "Imóvel NÃO cadastrado!" + vRet;
        }

        [AcceptVerbs("PUT")]
        [Route("AltImovel")]
        public string AlteraImovel(int xID, Imovel xImovel)
        {
            int vRet = 0;
            if (xImovel != null)
            {
                //vRet = nCorretor.AlteraCorretor(xID, xCorretor);
                if (vRet != 0)
                {
                    return "Imóvel alterado com sucesso!" + vRet;
                }
            }
            return "Imóvel NÃO alterado!" + vRet;
        }

        [AcceptVerbs("GET")]
        [Route("IdImovel/{id}")]
        public Corretor retImovelId(int id)
        {
            Imovel idImovel = new Imovel(); //.oCorretor(id);
            if (idImovel == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("FullImovel/{idCorretor}")]
        public List<Imovel> retImovel(int idCorretor)
        {
            List<Imovel> listImoveis = new List<Imovel>();//.listaCorretores();
            if (listImoveis == null)
            {
                return null;
            }
            return listImoveis;
        }
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

        [AcceptVerbs("POST")]
        [Route("CadCliente")]
        public string CadastroCliente(Cliente xCliente)
        {
            int vRet = 0;
            if (xCliente != null)
            {
                //vRet = nCorretor.NovoCorretor(xCorretor);
                if (vRet != 0)
                {
                    return "Cliente cadastrado com sucesso!" + vRet;
                }
            }
            return "Cliente NÃO cadastrado!" + vRet;
        }

        [AcceptVerbs("PUT")]
        [Route("AltCliente")]
        public string AlteraCliente(int xID, Cliente xCliente)
        {
            int vRet = 0;
            if (xCliente != null)
            {
                //vRet = nCorretor.AlteraCorretor(xID, xCorretor);
                if (vRet != 0)
                {
                    return "Cliente alterado com sucesso!" + vRet;
                }
            }
            return "Cliente NÃO alterado!" + vRet;
        }

        [AcceptVerbs("GET")]
        [Route("IdCliente/{id}")]
        public Corretor retClienteId(int id)
        {
            Imovel idCliente = new Imovel(); //.oCorretor(id);
            if (idCliente == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("FullCliente/{idCorretor}")]
        public List<Imovel> retCliente(int idCliente)
        {
            List<Cliente> listClientes = new List<Cliente>();//.listaCorretores();
            if (listClientes == null)
            {
                return null;
            }
            return null;
        }

        /// <summary>
        /// *********************
        /// **** FIM CLIENTE ****
        /// *********************
        /// </summary>

        /// <summary>
        /// **************************
        /// **** INICIO CADASTROS ****
        /// **************************
        /// </summary>

        [AcceptVerbs("GET")]
        [Route("status}")]
        public List<Cadastros.Status> retStatus()
        {
            List<Cadastros.Status> listStatus = new List<Cadastros.Status>();//.listaCorretores();
            if (listStatus == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("dormitorios}")]
        public List<Cadastros.Dormitorios> retDormitorios()
        {
            List<Cadastros.Dormitorios> listDormitorios = new List<Cadastros.Dormitorios>();//.listaCorretores();
            if (listDormitorios == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("faixa-preco}")]
        public List<Cadastros.FaixaPreco> retFaixaPreco()
        {
            List<Cadastros.FaixaPreco> listFaixaPreco = new List<Cadastros.FaixaPreco>();//.listaCorretores();
            if (listFaixaPreco == null)
            {
                return null;
            }
            return null;
        }
        
        /// <summary>
        /// ***********************
        /// **** FIM CADASTROS ****
        /// ***********************
        /// </summary>
        /// 
    }
}
