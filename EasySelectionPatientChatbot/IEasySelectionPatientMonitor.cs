using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySelectionPatientChatbot
{
    public interface IEasySelectionChatbot
    {
        void CreateDatabase();
        string ReadDatabase();
        void DisplayItems();
        void ResetItems();
        void AbortApplication();
        void BackPropagation();
    }
}
