Select * from apbd.Student;
Select * from apbd.Studies;
Select * from apbd.Student_Subject;
Select * from apbd.Subject;
select idStudies from apbd.Studies;
insert into apbd.Student values ('vitya','brando','UL.pituh','s1488',1);
insert into apbd.Studies values ('programing');
insert into apbd.Studies values ('farting');

insert into apbd.Subject values ('Money');
insert into apbd.Subject values ('Java');
insert into apbd.Subject values ('Jova');
insert into apbd.Subject values ('C--');
insert into apbd.Subject values ('C**');
insert into apbd.Subject values ('History');
insert into apbd.Subject values ('Anime');
insert into apbd.Student_Subject values (30,1,SYSDATETIME());
insert into apbd.Student_Subject values (30,2,SYSDATETIME());
insert into apbd.Student_Subject values (31,3,SYSDATETIME());
insert into apbd.Student_Subject values (32,4,SYSDATETIME());

update apbd.Student 