using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*This program prompts a user for the number of interior and exterior murals scheduled to be painted during the next month by Marshall's Murals.
 * Next, the program computers the expected revenue for each type of mural when internal murals cost $500 each and exterior murals cost $750 each.
 * The application also displays the total expected revenue and a statement that indicates whether more interior murals are schedule than exterior ones.
 * 
 * @authors - Sanders Tshinyama, Kamal Yusuf, and Maria Esteban
 * @version - 1.4 (09-18-23)
 * @since - 09-18-23
 */

namespace MarshallsRevenueProgram
{
    static class MarshallsRevenue
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
