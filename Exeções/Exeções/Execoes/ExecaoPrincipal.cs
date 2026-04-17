using System;
using System.Collections.Generic;
using System.Text;

namespace Exeções.Execoes
{
    internal class ExecaoPrincipal : ApplicationException
    {
        public ExecaoPrincipal(string message) : base(message)
        {
        }
    }
}
