﻿namespace DojoDDD.Api.DojoDDD.Domain.Models.Clientes
// Alterando o caminho para DojoDDD.Api.DojoDDD.Domain.Models.Clientes

{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public decimal Saldo { get; set; }
    }
}