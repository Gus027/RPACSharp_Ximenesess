using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02Leaf.Model
{
    internal interface ILoginRepository
    {
        void CheckLogin(string user, string password);

    }
}
