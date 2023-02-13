using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {

        //Dichiarazione del delegato
        public delegate void OrderInitialized(Order order);
        public delegate void ProcessCompleted();

        //Esposizione del delegato come public setter e public getter

        /*This property could now point to any method that corresponds with the method

        signature that we defined when declaring the delegate
        */
        public OrderInitialized OnOrderInitialized { get; set; }
        private void Initialize(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            //OnOrderInitialized();

            OnOrderInitialized?.Invoke(order);
            
        }

        public void Process(Order order, ProcessCompleted onCompleted=default)
        {
            // Run some code..

            Initialize(order);
            onCompleted?.Invoke();

            // How do I produce a shipping label?
        }
    }
}