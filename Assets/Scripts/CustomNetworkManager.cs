using Mirror;

public class CustomNetworkManager : NetworkManager
{
  public override void OnServerAddPlayer(NetworkConnection conn)
  {
    base.OnServerAddPlayer(conn);
  }
}
