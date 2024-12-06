using StackExchange.Redis;

namespace MultiShop.Basket.Settings
{
    public class RedisService
    {
        public string _host { get; set; }
        public int _port { get; set; }
        private ConnectionMultiplexer _connectionMultiplexer;
        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);
    }
}

//Bu kodda, Redis veritabanı bağlantısında iki önemli parametre kullanılmaktadır:

//_connectionMultiplexer.GetDatabase(0): Bu satırda 0 değeri, Redis sunucusundaki ilk veritabanını,
//ifade eder. Redis, varsayılan olarak 16 farklı veritabanı sunar ve bunlar sırasıyla 0'dan 15'e kadar numaralandırılır,
//Bu durumda 0, ilk veritabanına erişimi sağlar.

//GetDb(int db = 1): Bu parametreyi göz önünde bulundurduğumuzda, metodun varsayılan olarak 1.veritabanını,
//kullanacak şekilde ayarlandığını görebiliriz. Ancak, bu parametre üzerinden farklı bir veritabanı numarası da belirtilebilir.

//Özetle:

//0, ilk Redis veritabanını belirtir.
//1 ise metodun varsayılan olarak kullanacağı ikinci veritabanıdır.


