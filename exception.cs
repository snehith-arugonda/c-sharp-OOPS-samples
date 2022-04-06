namespace app{
    [Serializable]
    public class CustomException: Exception{
        public CustomException():base(){}
        public CustomException(string message):base(message){}
        public CustomException(string message, Exception e):base(message, e){}
    }
}