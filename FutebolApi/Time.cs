using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolApi
{
    public class Time
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cidade { get; set; }
        public int TitulosBrasileiros { get; set; }
        public int TitulosMundiais { get; set; }
    }
}