using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagement.Interface
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void DisplayUserName(string name);
        void ShowMessage(string message);
    }
}
