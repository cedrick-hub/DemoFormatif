using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalA22
{
    public class Grinch
    {
        /**
        * Attributs:
        *   - nbCadeaux : nombre entier
        *   - listeCadeaux : un tableau (ou une liste) de chaînes de caractères 
        */

        /**
        * Constructeur: initialisation des attributs
        *   - nbCadeaux : le nombre de cadeaux à remplacer
        *   - listeCadeaux : correspond aux cadeaux personnels du Grinch
        *   @param: le nombre de cadeaux à remplacer
        */

        /**
        * remplirListeCadeaux: Compléter la méthode afin que 
        * les cadeaux soient placés dans le tableau des cadeaux personnels du Grinch
        * Appeler cette méthode à la construction de l’objet. 
        */
        public void remplirListeCadeaux()
        {
            StreamReader lecteur = new StreamReader("cadeaux.txt");
        }

        /**
        * changerCadeau: change un cadeau pour un cadeau du grinch et l'affiche à l'écran après
        * @param string taille : la taille du cadeau sous le sapin
        * @param string couleur : la couleur du cadeau sous le sapin
        */
        public void changerCadeau(string taille, string couleur)
        { 
            
        }

        /**
        * afficherGrinch : Affiche le Grinch à l'écran
        * Crédits: https://ascii.co.uk/art/grinch
        */
        public void afficherGrinch()
        {
            Console.WriteLine("                       __..._\r\n                    ,-`      `',\r\n                  ,'            \\\r\n                 /               |\r\n               ,'       ,        \\\r\n             ,'       ,/-'`       \\\r\n         _ ./     ,.'`/            \\\r\n      .-` `^\\_,.'`   /              `\\__\r\n      7     /       /   _,._,.,_,.-'.`  `\\\r\n      \\A  __/   ,-```-``   `,   `,   `  ,`)\r\n        ^-`    /      `                 ,/     -ART BY-\r\n               (        ,   ,_   ,-,_,<`        -ZEUS-\r\n                \\__ T--` `''` ```    _,\\\r\n                  \\_/|\\_         ,.-` | |\r\n                  _/ | |T\\_   _,'Y    / +--,_\r\n              <```   \\_\\/_/  `\\\\_/   /       `\\\r\n              /  ,--   ` _,--,_`----`   _,,_   \\\r\n             /  ` |     <_._._ >       `  \\ `  \\`\r\n            |     |       ,   `           |     |\r\n             V|   \\       |                |   |`\r\n              \\    \\      /               /    /\r\n               \\x   \\_   |             /-`    /\r\n                 \\    `-,|        ,/--`     /`\r\n                  \\x_    \\_  /--'`       , /\r\n                     \\x_   ``        ,,/` `\r\n                        `-,_,-'   ,'`\r\n                         _|       |`\\\r\n                        ( `-``/``/`_/\r\n                         `-`-,.-.-`");
        }
    }
}
