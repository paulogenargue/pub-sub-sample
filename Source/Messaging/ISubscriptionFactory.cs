namespace Messaging
{
   public interface ISubscriptionFactory<T>
   {
       ISubscription<T> Create();
   }
}