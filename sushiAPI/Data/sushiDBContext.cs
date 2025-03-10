using Microsoft.EntityFrameworkCore;
using sushiAPI.models;
using sushiAPI.Entities;

namespace sushiAPI.Data
{
    public class sushiDBContext : DbContext
    {
        public sushiDBContext(DbContextOptions<sushiDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
         new Product
       {
         ProductId = 1,
         ProductName = "Liten sushi 8 bitar",
         ProductDescription = "3 lax, 1 räka, 1 avokado, 3 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
         ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHC97aSO8QolfP_75c905eSbFjSYFkuHRmzA&s",
         ProductPrice = 110,
      },
       new Product
     {
        ProductId = 2,
        ProductName = "Mellan sushi 11 bitar",
        ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
        ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6M9H7I418gOLiVZ48aXGo5GNIhNjf1XMi4w&s",
        ProductPrice = 145,
     },
      new Product
     {
       ProductId = 3,
       ProductName = "Stor sushi 14 bitar",
       ProductDescription = "5 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
       ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_rPIccq0sVCTu6Vypgs5qg9mkNLiaVqRn5g&s",
       ProductPrice = 165,
    },
    new Product
    {
      ProductId = 4,
      ProductName = "Lätt grillad 8 bitar",
      ProductDescription = "Halstrad lax med chilimajonnäs, ålsås, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwXWRc-bVTqjz_uRMjBh7pJP3amHNOBBE5zA&s",
      ProductPrice = 150,
   },
   new Product
   {
      ProductId = 5,
      ProductName = "Yume special sushi 11 bitar",
      ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 ål, 1 bläckfisk, chillimajonäs, ålsås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk2AIUIoGdq8t0h5THZYxnP4XqGMpsbILMhw&s",
      ProductPrice = 165,
   },
   new Product
   {
      ProductId = 6,
      ProductName = "Lax sushi 9 bitar",
      ProductDescription = "9 bitar laxnigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwY_15mOvAKlD2J6J9JpDweEpBhnS2BH5CWQ&s",
      ProductPrice = 150,
   },
   new Product
   {
      ProductId = 7,
      ProductName = "Lax avokado sushi 9 bitar",
      ProductDescription = "5 lax, 4 avokado, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ48iaAy81c6BCNL1QOMYUaAzh5O6i5yVlkVw&s",
      ProductPrice = 145,
   },
   new Product
   {
      ProductId = 8,
      ProductName = "Lax räkor sushi 9 bitar",
      ProductDescription = "5 lax, 4 räkor, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXPraCfYN857lbWbxZ9-n8TrELfOS4XpCTfw&s",
      ProductPrice = 145,
   },
   new Product
   {
      ProductId = 9,
      ProductName = "Räk sushi 9 bitar",
      ProductDescription = "9 bitar räknigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSaBo81jS3KYx4bSDzJKopZDApnvPVNEuAuCA&s",
      ProductPrice = 145,
    },
   new Product
   {
      ProductId = 10,
      ProductName = "Vegetarisk sushi 9 bitar",
      ProductDescription = "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI87TnpM3n3bSd-3N-fwG1SBG_7NXny0qjJA&s",
      ProductPrice = 120,
   },
   new Product
   {
      ProductId = 11,
      ProductName = "Vegetarisk sushi 12 bitar",
      ProductDescription = "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEnuqODIUMocXlMm054D1G0-hfJ-J_-TcXIw&s",
      ProductPrice = 140,
   },
   new Product
   {
      ProductId = 12,
      ProductName = "Mamma sushi 9 bitar",
      ProductDescription = "2 avokado, 1 räka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS016V_D80oDQ1kgaudn-6JUcr6zucxWG08fw&s",
      ProductPrice = 120,
   },
   new Product
   {
      ProductId = 13,
      ProductName = "Mamma sushi 12 bitar",
      ProductDescription = "4 avokado, 1 räka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS7h189nxA56bT7-gZEVpm0bzSr6s2YTxW_5g&s",
      ProductPrice = 140,
   },
   new Product
   {
      ProductId = 14,
      ProductName = "Sashimi mellan",
      ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö och rostad lök",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSO5OIdUxpnygTC86_eWbfM8ifJqNAylwSBRQ&s",
      ProductPrice = 205,
   },
   new Product
   {
      ProductId = 15,
      ProductName = "Sushi 6 bitar och sashimi",
      ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTbYpfW_Sfcs4e-W3eXIkv83jbd0h2jOMv2Q&s",
      ProductPrice = 250,
   },
   new Product
   {
      ProductId = 16,
      ProductName = "Yume special roll 10 bitar",
      ProductDescription = "Lax, tonfisk, avokado, gurka, crabstick surimi, ål sås, chilimajonnäs, sesamfrö och rostad lök.",
      ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr7l1LmWInyy3_hdsohHWI-xsjV6CauBtvHw&s",
      ProductPrice = 165,
   }
  );

            modelBuilder.Entity<Order>()
                 .Property(e => e.TotalAmount)
                 .HasPrecision(18, 2);

            modelBuilder.Entity<Product>()
                 .Property(e => e.ProductPrice)
                 .HasPrecision(18, 2);

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
