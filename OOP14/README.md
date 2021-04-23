![image](https://user-images.githubusercontent.com/55552780/115602143-45600d80-a2e7-11eb-9732-d900a3c625fe.png)  

----

![image](https://user-images.githubusercontent.com/55552780/115602373-8a843f80-a2e7-11eb-8e07-2054ab390883.png)  
![image](https://user-images.githubusercontent.com/55552780/115602437-9b34b580-a2e7-11eb-93fd-4c64507b2c8a.png)  
![image](https://user-images.githubusercontent.com/55552780/115603402-c8359800-a2e8-11eb-8c51-5a62150a237d.png)  

## Console Output
Початковий вигляд колекції з об'єктами **Dog**: <br>
![image](https://user-images.githubusercontent.com/55552780/115850269-63845580-a42e-11eb-8afa-0703f08951f5.png)  
<br>
Сортована (за **id**) колекція з **Dog**: <br>
![image](https://user-images.githubusercontent.com/55552780/115851002-253b6600-a42f-11eb-8373-6d9459f8a7bb.png)  
<br>
Витягнута з файлу колекція з **Dog** (поле **id** не серіадізується - як бачимо, всі id об'єктів колекції набувають значення за замовчуванням):  
![image](https://user-images.githubusercontent.com/55552780/115849767-e0fb9600-a42d-11eb-84ec-45f3458ba972.png)

----

## Контрольні питання  
#### 1. Для чого призначений простір імен **System.IO**?  
Для роботи з файлами, введення/виведення даних у файли.  
#### 2. Які класи для роботи з файлами і папками ви знаєте?
File, FileStream, BinaryFormatter, StreamReader, StreanWriter, BinaryWriter, BinaryReader.  
#### 3. Що таке серіалізація?  
Перетворення даних в потік байтів, які можна зберегти у файл або тримати тимчасово у пам'яті.  
#### 4. Що міститься в просторі імен **System.Runtime.Serialization.Formatters**?  
Класи, інтерфейси, enum типи, що використовуються для серіалізації об'єктів.  
#### 5. Які формати серіалізації ви знаєте?  
Бінарний, SOAP, XML.  
#### 6. Для чого призначені інтерфейси **IFormatter** і **IRemotingFormatter**?  
