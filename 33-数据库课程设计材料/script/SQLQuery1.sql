	CREATE TABLE ѧ��(
	ѧ�� CHAR(20),
	���� CHAR(10),
    �˻����� CHAR(20),
	רҵ CHAR(10),
	PRIMARY KEY (ѧ��)
	)
	GO
	CREATE TABLE ��ʦ(
	��ʦ�˺� CHAR(20),
	���� CHAR(20),
	���� CHAR(10),
	�γ̺� CHAR(10),
	�γ����� CHAR(10),
	PRIMARY KEY (��ʦ�˺�)
	
	)
	GO
	CREATE TABLE ��ҵ(
	��ҵ���� CHAR(20),
	�γ̺� CHAR(10),
	ѧ�� CHAR(20),
	��ҵ���� CHAR(10),
	��ҵ���� VARCHAR(300),
	PRIMARY KEY (ѧ��,�γ̺�),
	FOREIGN KEY (ѧ��) REFERENCES ѧ��(ѧ��)

	)
	GO
