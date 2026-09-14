string enhet1 = "Laptopsal 1";
string id1 = "D-100";
string status1 = "Aktiv";
int price1 = 250;

string enhet2 = "Projektor 1";
string id2 = "D-200";
string status2 = "Service";
int price2 = 450;

string enhet3 = "Skrivare 1";
string id3 = "D-300";
string status3 = "Inaktiv";
int price3 = 300;

string enhet4 = "Tangentbord 1";
string id4 = "D-400";
string status4 = "Aktiv";
int price4 = 350;

double moms = 0.25;

string[] id = { id1, id2, id3, id4 };
string[] namn = { enhet1, enhet2, enhet3, enhet4 };
string[] status = { status1, status2, status3, status4 };
int[] priser = { price1, price2, price3, price4 };

Console.WriteLine("=== Enhetsregister ===");

for (int i = 0; i < namn.Length; i++)
{
    double priceWithTax = priser[i] * (1 + moms);
    Console.WriteLine($"ID {id[i]} | Namn: {namn[i]} | Status: {status[i]} | Pris: {priser[i]} kr | Pris inkl. moms: {priceWithTax:F2} kr");
}
