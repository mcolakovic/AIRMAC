using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        GetAircrafts,
        GetAircraft,
        GetAirports,
        AddLogBook,
        GetLogBook,
        GetFlight,
        UpdateLogBook,
        SearchRotableParts,
        AddRotableParts,
        UpdateRotableParts,
        SearchRotablePartsStock,
        InstallToAircraft,
        SearchResourceAvailability,
        SearchRotablePartsAircraft,
        SendFromAircraftToStock,
        SendToService,
        SearchRotablePartsService,
        SearchUnservicable,
        ServiceInspection,
        SearchServiceable,
        SendFromServiceToStock,
        Login,
        EndConnection,
        AddUser,
        SearchRemainingHours,
        SearchRemainingCycles,
        SearchRemainingDays,
        SearchRotablePartHistory,
        AddAircraft
    }
}
