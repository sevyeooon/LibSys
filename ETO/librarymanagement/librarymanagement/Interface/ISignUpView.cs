using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagement.Interface
{
   public interface ISignUpView
    {
        string Name { get; }
        string Email { get; }
        string Password { get; }
        string Contact { get; }
        string Role { get; }
        void ShowErrorMessage(string message);
    }
}
