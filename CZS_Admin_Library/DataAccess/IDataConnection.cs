using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZS_Admin_Library.Models;

namespace CZS_Admin_Library.DataAccess
{
    public interface IDataConnection
    {
        bool Cliente_Create(ClienteModel model);

        List<ClienteModel> Cliente_GetAll();

        bool Cliente_Update(ClienteModel model);
    }
}
