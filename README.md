# Visual Basic example : Products database using SQL Server 2014 #

This work was done by me, Fabien Roy, during my last year of college. This program is an inventory tracker that uses SQL Server 2014 and what my teacher thought was LinQ (he was wrong, it was only Entity Framework...).

It was made for my college's COOP. Of course, all their inventory data was stripped from the program for obvious reasons.

Beware, if I was to make this exercise again, I would change a lot of it. There are many dumb things in there, half of which because of the exercice's requirements. The other half? Because it's the first time I used Visual Basic, Entity Framework and SQL Server 2014. Also also beware, it's full of French, since my college asked the usage of French in all of our programs.

This exercice was in three parts : 

	Inventory worked with a text file
	Inventory worked with SQL Server 2014 and raw queries
	Inventory worked with SQL Server 2014 and Entity Framework

## Bugs and features ##

### Features I didn't have time to add ###

	The program should not have to get inventory data when we cancel adding/editing an item.
	Users are not linked to SQL Server 2014 users. Rights and authentification server-side works perfectly, though.
	Invoices comments are not saved.

### Bugs I didn't have time to solve ###

	Invoices totals are not calculated the same way in the invoices' DataGridView and in invoices' editing form. Totals are not equal in those two places.

### Bugs I couldn't solve* ###

	Item filtering and search bar cannot work at the same time.
	If there are too many items in an invoice, the invoice cannot be printed completly. This is because I use a simple screenshot of a window to print. I know, that sucks. As I said, I was not a Visual Basic expert at the moment.

*The exercice was in three parts. Say I had an unsolved bug when I handed over part 1, I was not allowed to solve it during part 2.
