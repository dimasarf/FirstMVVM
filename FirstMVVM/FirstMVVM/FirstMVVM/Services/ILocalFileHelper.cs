using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Services
{
    public interface ILocalFileHelper
    {
        string GetLocalPath(string FileName);
    }
}
