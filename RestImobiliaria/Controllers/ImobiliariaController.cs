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
        [AcceptVerbs("POST")]
        [Route("loginUser")]
        public bool retCorretorId(string email, string senha, out int xID)
        {
            Corretor RoCorretor = new Corretor();
            bool xcont = new Corretor().loginCorretor(email, senha, out RoCorretor);

            xID = RoCorretor.Id;
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
        [Route("Status")]
        public List<Status> retStatus()
        {
            List<Status> listStatus = new List<Status>();//.listaCorretores();
            if (listStatus == null)
            {
                return null;
            }
            return null;
        }
        
        [AcceptVerbs("GET")]
        [Route("dormitorios")]
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
        [Route("faixa-preco")]
        public List<Cadastros.FaixaPreco> retFaixaPreco()
        {
            List<Cadastros.FaixaPreco> listFaixaPreco = new List<Cadastros.FaixaPreco>();//.listaCorretores();
            if (listFaixaPreco == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("estagio-obra")]
        public List<Cadastros.EstagioObra> retEstagioObra()
        {
            List<Cadastros.EstagioObra> listEstagioObra = new List<Cadastros.EstagioObra>();//.listaCorretores();
            if (listEstagioObra == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("operacao")]
        public List<Cadastros.Operacao> retOperacao()
        {
            List<Cadastros.Operacao> listOperacao = new List<Cadastros.Operacao>();//.listaCorretores();
            if (listOperacao == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("metragem")]
        public List<Cadastros.Metragem> retMetragem()
        {
            List<Cadastros.Metragem> listMetragem = new List<Cadastros.Metragem>();//.listaCorretores();
            if (listMetragem == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("tipo-imagem")]
        public List<Cadastros.TpImovel> retTpImovel()
        {
            List<Cadastros.TpImovel> listTpImovel = new List<Cadastros.TpImovel>();//.listaCorretores();
            if (listTpImovel == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("tipo-operacao")]
        public List<Cadastros.TpOperacao> retTpOperacao()
        {
            List<Cadastros.TpOperacao> listTpOperacao = new List<Cadastros.TpOperacao>();//.listaCorretores();
            if (listTpOperacao == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("uf")]
        public List<Cadastros.Uf> retUf()
        {
            List<Cadastros.Uf> listUf = new List<Cadastros.Uf>();//.listaCorretores();
            if (listUf == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("vagas")]
        public List<Cadastros.Vagas> retVagas()
        {
            List<Cadastros.Vagas> listVagas = new List<Cadastros.Vagas>();//.listaCorretores();
            if (listVagas == null)
            {
                return null;
            }
            return null;
        }

        [AcceptVerbs("GET")]
        [Route("zona-cidade")]
        public List<Cadastros.ZonaCidade> retZonaCidade()
        {
            List<Cadastros.ZonaCidade> listZonaCidade = new List<Cadastros.ZonaCidade>();//.listaCorretores();
            if (listZonaCidade == null)
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
