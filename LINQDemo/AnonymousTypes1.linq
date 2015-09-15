<Query Kind="Expression">
  <Connection>
    <ID>09f429eb-20ed-40ca-951e-cd7110428fb4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
	Description  = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}