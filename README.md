## Configurando o git

### create a new repository on the command line
echo "# reserva_hotel" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/glauciaandare/reserva_hotel.git
git push -u origin main
### push an existing repository from the command line
git remote add origin https://github.com/glauciaandare/reserva_hotel.git
git branch -M main
git push -u origin main
