namespace VandarSharp.Core.Models
{
    public class BaseResponse<T>
    {
        public int status { get; set; }
        public T data { get; set; }
    }

    public class Data<T>
    {
        public T Item { get; set; }
    }
}
