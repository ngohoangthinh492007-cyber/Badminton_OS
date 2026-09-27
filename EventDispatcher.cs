namespace Badminton;
public static class EventDispatcher 
{
    private static List<IEventListener> listeners = new List<IEventListener>();

    public static void ĐăngKý(IEventListener listener) => listeners.Add(listener);

    public static void PhátSựKiện(IEvent e) 
    {
        foreach (var listener in listeners) 
        {
            listener.HandleEvent(e);
        }
    }
}