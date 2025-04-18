﻿using System.Collections.Generic;

namespace WFConFin.Models
{
    public class PaginacaoResponse<T> where T : class
    {
        private IEnumerable<Cidade> lista;
        private int qtde;

        public IEnumerable<T> Dados { get; set; }
        public long TotalLinhas { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public PaginacaoResponse(IEnumerable<T> dados, long totalLinhas, int skip, int take)
        {
            Dados = dados;
            TotalLinhas = totalLinhas;
            Skip = skip;
            Take = take; 
        }

        /*public PaginacaoResponse(IEnumerable<Cidade> lista, int qtde, int skip, int take)
        {
            this.lista = lista;
            this.qtde = qtde;
            Skip = skip;
            Take = take;
        }*/
    }
}
