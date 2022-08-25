namespace PayCoreClassWork1.Classes
{
    public class Interest
    {
        // InterestsController'in GetInterest adlı action metodunun dönüş cevabı olarak kullanılması için oluşturulmuş yapıcı metoddur.
        public Interest(double totalBalance, double rate)
        {
            // Parametreye gönderilen değerler propertylere atanır.
            TotalBalance = totalBalance;
            Rate = rate;
        }

        // Vade sonunda elde edilen toplam bakiye.
        public double TotalBalance { get; set; }

        // Faiz oranı.
        public double Rate { get; set; }
    }

    // Faiz tiplerine ait hesaplama türüne ilişkin validasyonun sağlanması adına oluşturulmuş faiz tipi enum'u.
    // Action metodunda parametre olarak bool tipi de kullanılabilirdi ancak geleceğe yönelik ihtiyaçların artması durumunda tüm ihtimalleri bünyesinde barındıran bir enum olması daha sağlıklıdır.
    public enum InterestType { Simple, Compound }
}