	CREATE TABLE 学生(
	学号 CHAR(20),
	姓名 CHAR(10),
    账户密码 CHAR(20),
	专业 CHAR(10),
	PRIMARY KEY (学号)
	)
	GO
	CREATE TABLE 老师(
	老师账号 CHAR(20),
	密码 CHAR(20),
	姓名 CHAR(10),
	课程号 CHAR(10),
	课程名称 CHAR(10),
	PRIMARY KEY (老师账号)
	
	)
	GO
	CREATE TABLE 作业(
	作业名称 CHAR(20),
	课程号 CHAR(10),
	学号 CHAR(20),
	作业评分 CHAR(10),
	作业内容 VARCHAR(300),
	PRIMARY KEY (学号,课程号),
	FOREIGN KEY (学号) REFERENCES 学生(学号)

	)
	GO
