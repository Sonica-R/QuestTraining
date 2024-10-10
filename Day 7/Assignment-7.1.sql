--CREATE TABLE studententries(
--	id INT PRIMARY KEY IDENTITY NOT NULL,
--	name varchar(50),
--	class INT
--)

--CREATE TABLE subject(
--	sub_id INT PRIMARY KEY IDENTITY,
--	sub_name varchar(50) NOT NULL,
--	sub_code BIGINT UNIQUE
--)

--CREATE TABLE exam(
--	exam_id INT PRIMARY KEY,
--	max_mark int,
--	min_mar int
--)

--CREATE TABLE marks (
--	marks_scored INT,
--	exam_id INT,
--   student_id INT,
--
--	subject_id INT,
--CONSTRAINT FK_marks_student_id FOREIGN KEY (student_id) REFERENCES studententries(id),  
--CONSTRAINT FK_marks_exam_id FOREIGN KEY (exam_id) REFERENCES exam(exam_id), 
--CONSTRAINT FK_subject_id FOREIGN KEY(subject_id) REFERENCES subject(sub_id)
--);

--INSERT INTO studententries (name, class) VALUES
--('Alice', 10),
--('Bob', 9),
--('Charlie', 11),
--('Dave', 8),
--('Eve', 10),
--('Frank', 12),
--('Grace', 9),
--('Hank', 11),
--('Ivy', 8),
--('Jack', 12);

--INSERT INTO subject (sub_name, sub_code) VALUES
--('Mathematics', 1001),
--('Physics', 1002),
--('Chemistry', 1003),
--('Biology', 1004),
--('English', 1005),
--('History', 1006),
--('Geography', 1007),
--('Computer Science', 1008),
--('Economics', 1009),
--('Art', 1010);*/

--INSERT INTO exam (exam_id, max_mark, min_mar) VALUES
--(101, 100, 35),  
--(102, 100, 40),  
--(103, 100, 30),  
--(104, 100, 45),  
--(105, 100, 50),  
--(106, 100, 20), 
--(107, 100, 25),  
--(108, 100, 33),  
--(109, 100, 38),  
--(110, 100, 42);  

--INSERT INTO marks (marks_scored, exam_id, student_id, subject_id) VALUES
--(85, 101, 1, 1),  
--(90, 102, 2, 2),   
--(78, 103, 3, 3),  
--(92, 104, 4, 4),   
--(75, 105, 5, 5),  
--(88, 106, 6, 6),  
--(80, 107, 7, 7),   
--(95, 108, 8, 8),  
--(70, 109, 9, 9),   
--(83, 110, 10, 10);

SELECT studententries.name, marks.marks_scored FROM marks 
INNER JOIN 
studententries 
ON marks.student_id = studententries.id;

SELECT studententries.id, marks.marks_scored
FROM marks 
INNER JOIN studententries ON marks.student_id = studententries.id
INNER JOIN subject ON marks.subject_id = subject.sub_id
WHERE subject.sub_name = 'Biology';

--SELECT  studententries.id, studententries.name, studententries.class, exam_id from students 
--INNER JOIN 
--exam ON studententries.id = exam.id;



 






 



