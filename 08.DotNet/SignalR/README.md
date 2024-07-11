# What is SignalR?

SignalR is a library for adding real-time web functionality to ASP.NET applications. Real-time web functionality means the ability to have server-side code push content to connected clients instantly. SignalR facilitates real-time communication by allowing users to send and receive messages between the server and clients in real-time.

### Key Features of SignalR:

1. **Real-Time Communication**: SignalR is used to implement real-time data updates in web applications. For example, messages in a chat application are instantly delivered to other users.

2. **Automatic Fallback**: SignalR automatically selects the best transport method (WebSockets, Server-Sent Events, Long Polling) depending on the client and server capabilities.

3. **Group Management**: SignalR allows you to manage groups of users for group-based messaging.

4. **Connection States**: SignalR can monitor the connection states of users (connected, disconnected, reconnecting, etc.).

### Use Cases for SignalR:
- **Live Chat Applications**: Applications where users can send and receive messages instantly.
- **Real-Time Games**: Multiplayer games where users can play simultaneously.
- **Notification Systems**: Systems that require instant notifications for users.
- **Real-Time Dashboards**: Dashboards and analytical tools that need real-time data updates.
- **Live Streaming and Sports Scores**: Instant score updates during live streaming or sports events.

### Sample SignalR Code

**Server Code (Hub)**:
```csharp
public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
```

**Client Code (JavaScript):**:
```javascript
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();

connection.on("ReceiveMessage", (user, message) => {
    const msg = user + ": " + message;
    console.log(msg);
});

connection.start().catch(err => console.error(err.toString()));
```

## Example

- #### [First.WebAPI](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/08.DotNet/SignalR/First.WebAPI)