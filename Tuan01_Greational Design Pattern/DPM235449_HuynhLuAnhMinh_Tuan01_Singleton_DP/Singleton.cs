namespace RefactoringGuru.DesignPatterns.Singleton.Conceptual.NonThreadSafe
{
    // Lớp Singleton được khai báo 'sealed' để ngăn chặn kế thừa
    public sealed class Singleton
    {
        private static Singleton _instance;

        // Constructor private để chặn việc khởi tạo trực tiếp bằng từ khóa 'new'
        private Singleton() { }

        // Phương thức tĩnh điều hướng truy cập vào instance duy nhất
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void SomeBusinessLogic()
        {
            // Xử lý logic nghiệp vụ tại đây
        }
    }
}