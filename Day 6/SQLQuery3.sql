--INSERT into courses(course_name, course_id, student_id, fees) VALUES 
--('CSE', 'CS101', '1101',30000),
--('CSE', 'CS101','1102', 50000),
--('ECE', 'ECE121','1103',50000),
--('ECE', 'ECE121', '1104',30000),
--('AE', 'AE131','1105',50000),
--('AE', 'AE131','1106',30000)

--SELECT course_name, COUNT(course_id) AS COUNT FROM coursesGROUP BY course_name;

--SELECT course_name, SUM(fees) as total_fees_percourse from courses GROUP BY course_name;

SELECT course_id, course_name WHERE MAX(course_id);

