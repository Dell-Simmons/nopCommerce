using elFinder.NetCore;

namespace Nop.Services.Media.ElFinder;

/// <summary>
/// elFinder service interface
/// </summary>
public partial interface IElFinderService
{
    /// <summary>
    /// Configure elFinder connector
    /// </summary>
    /// <returns>Connector</returns>
    Connector GetConnector();

}
