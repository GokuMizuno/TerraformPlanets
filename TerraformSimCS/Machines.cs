namespace TerraformSimCS
{
    class Machine {
    }
    class Colony : Machine {
    }
    class Probe : Machine {
    }
    class sealedColony : Colony {
    }
    class openColony : Colony {
    }
    class LandColony :  sealedColony//, openColony
    {}
    class AirColony : sealedColony {
    }
}
 