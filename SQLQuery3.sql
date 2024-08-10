create table tbl_items(
id int identity(1,1) primary key,
itemname varchar(max),
quantitytype varchar(max),
latestprice float,
latestpriceupdatedtimne datetime,
createdtime datetime default getdate() 
)

drop table tbl_items


select * from tbl_items

insert into tbl_items (itemname,quantitytype,latestprice)values ('iron','kg',100)

delete from tbl_items



