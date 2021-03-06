/*List of nutrients, such as water, ammonia, nitrogen, atp, et al.
  may split off elements later
http://en.wikipedia.org/wiki/Soil
 */

/*Need to encapsulate in RAII*/
namespace TerraformSimCS {
    struct nutrients {
        double good;// = 1;  //placeholder  check to make sure always less than one
        double bad;// = 1- good;
    }
    class Planet
    {
        private double rotation;
        private double mass;
        private double gravity;
        public double solarIrradiation; //watts per meter
    }
    class Water : Planet { //oceans, et al.
        double acidity;  //relative acidity of H2O.  If too high, or too low, life no go.
        bool shallow;  //shallow or deep water.  If bounded by land, is shallow.  Else, random
    }
    class BaseSoil : Planet {
        /*has water content, nutrient content, soil type, layer number
         * */
        int layerheight;
        double water; //water content as a percentage
        //nutrients.good ngood;
        //nutrients.bad nbad;
        double ngood;// = new nutrients.good();  //need to use in constructor
        double nbad;// = new nutrients.bad;
        struct soilbase {
            double sand, silt, clay;
        }
        // enum texture = {organic, inorganic, loam};
        // enum structure = {};
        double density;
        double porosity;
        double consistency;
        double temperature;
        double color;
        double resistivity;
    }
    class Bedrock : BaseSoil
    {
       // virtual void whaargarbbl; //placeholder name, replace
    }
    class Atmosphere : Planet {
        private
        bool toxic;  //is atmosphere condusive to life?
        int layerheight;
        bool isGreenHouse;
        public
        double H;
        double O;
        double O2;
        double N2;
        double H2O;
        double CO2;
        double toxins; //percent of atm
        double inert; //other
        double temperature;  //Planet.Temperature + Planet.BaseSoil.temperature * greenhouse modifier - layerheight
    }
       
}
 