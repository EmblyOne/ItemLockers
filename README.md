![download (1)](https://user-images.githubusercontent.com/69349110/152858817-687d2a9c-7339-4c2a-9b24-5947daaefeef.gif)
# ItemLockers
ItemLockers is a plugin which can spawn items in lockers, pedestal and etc.  

# Example Image
![image](https://user-images.githubusercontent.com/69349110/152858161-6375b2d1-0c0c-4a19-9ed3-df5660eabd72.png)

# Configs
```yaml
Name: ItemLockers
Enabled: true
# The List with items that will spawn in locker
lockers:
  StandardLocker:
  - amount: 1
    chance: 35
    item: Medkit
  - amount: 1
    chance: 10
    item: Adrenaline
# The list with lockers which won't spawn base game items
ItemInLockersDisabler:
  StandardLocker: true
``` 
