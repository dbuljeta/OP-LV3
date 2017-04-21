<h1> OP-LV3</h1>

Prilikom izrade ovog projekta nije bilo većih problema osim što sam za otvaranje dokumenata koristio
klasu StreamReader (zakomentirani dio koda) te mi je bilo samo omogućeno otvaranje .txt datoteka. Prilikom učitavanja (otvaranja) dokumenta
korištena je metoda LoadFile koja čita tekstualnu datoteku otvorenu preko OpenFileDialog-a,  te sadržaj pročitanog dokumenta upisuje u 
richTextBox. Kako bi se napisani sadržaja unutar richTextBoxa spremio u tekstualni dokument potrebno je u formu dodati SaveFileDialog, 
te kako bi se dokument kasnije mogao iščitavati sa različitim fontovima i bojama sadržanim unutar teksta potrebno je spremiti kao
.rtf datoteku, te ukoliko želimo ponovno otvoriti datoteku sa različitim bojama i fontovima, potrebno je otvoriti .rtf datoteku.
Za biranje fonta i boje potrebno je dodati font dialog i color dialog u formu.
