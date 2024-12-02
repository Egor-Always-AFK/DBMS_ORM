# DBMS_ORM

## Artists table
- **CREATE ARTIST**
```
*/api/artist/addArtist
```
In body
```
{
	"name": "",
	"bio": ""
}
```

---
- **READ ARTIST**
```
/api/artist/{name}
```
Empty body

---
- **UPDATE ARTIST**
```
*/api/artist/updateArtist
```
In body
```
{
	"name":"",
	"bio":""
}
```
---
- **DELETE ARTIST**
```
/api/artist/deleteArtist/{name}
```
Empty body
