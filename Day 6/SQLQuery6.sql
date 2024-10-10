INSERT into courses(course_name, course_id, student_name, student_id, fees) VALUES 
('CSE', 'CS101', 'Abhi','ABC101','30,000'),
('CSE', 'CS101', 'Anu','ABC102', '50,000'),
('ECE', 'ECE121', 'Adhi','ABC103','50,000'),
('ECE', 'ECE121', 'Brien','ABC104','30,000'),
('AE', 'AE131', 'Cyan','ABC105','50,000'),
('AE', 'AE131', 'Cen','ABC106','30,000')

SELECT course_name, COUNT(*) AS COUNT from courses;

SELECT course_name, COUNT(fees) as count_fees from courses;

SELECT course_name, COUNT(STUDENT_ID) AS enrollments from courses;