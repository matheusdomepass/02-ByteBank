﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios.Sistema
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
        
    }
}
