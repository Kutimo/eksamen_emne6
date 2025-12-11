# Eksamen Emne 6 - Software Design - TODO

## Oppgave 1: Blazor WebAssembly App

### Grunnleggende oppsett
- [x] Opprett nytt Blazor WebAssembly-prosjekt (standalone, ingen backend)
- [x] Sett opp HttpClient med Dependency Injection
- [x] Opprett service for Random User API-kommunikasjon

### Funksjonelle krav

**1. Hente og vise brukere**
- [x] Hent minst 10 brukere fra `https://randomuser.me/api/?results=10`
- [x] Vis brukere i liste/tabell/kort-format
- [x] For hver bruker, vis:
    - [x] Profilbilde (thumbnail/medium/large)
    - [x] Fullt navn
    - [x] Kjønn
    - [x] Land
    - [x] E-post

**2. Detaljvisning**
- [x] Implementer klikk-handling på bruker i lista
- [x] make modal for this and onclickOutside and escape key close
- [x] Vis detaljside med:
    - [x] Større bilde (medium/large)
    - [ ] Fullt navn
    - [ ] Alder
    - [ ] Kjønn
    - [ ] Adresse (by og land)
    - [ ] E-post
    - [ ] Telefonnummer

**3. Filtrering/søk (minst én)**
Make a search bar
- [x] Filtrering på kjønn (male/female/alle)
- [x] Filtrering på land
- [x] Søk etter navn

**4. Oppdater brukere**
- [x] "Hent nye brukere"-knapp
- [x] Nytt API-kall ved klikk
- [x] Oppdater listevisning

4.5
- [ ] Make a nice error page and error blazor error.

**5. Feilhåndtering**
- [x] Håndter lastetilstand (loading spinner/melding)
- [x] Håndter feil ved API-kall (feilmelding til bruker)

Annet: 
- [x] favicon
- [ ] fix ugly errors
- [x] make CSS lib with reusable code
- [x] remove duplcate css in app.css and razor.css files and change to css class lib.
- [ ] accesibility checks
- [ ] remove unused props in model for api call
- [ ] change button to just x in modal
- [] fix errors in markdown.css
- 
Testing:
- [ ] unit test 
- [ ] integrasjonstest
---

## Oppgave 2: Video (8-12 min)

- [ ] Lag disposisjon/manus
- [ ] Demonstrer applikasjonen
- [ ] Forklar arkitektur:
    - [ ] Komponenter
    - [ ] Services
    - [ ] State-håndtering
- [ ] Gå gjennom nøkkelkode
- [ ] Vis og begrunn UI/UX-valg
- [ ] Reflekter over utfordringer og løsninger
- [ ] Kjør minst én unit test LIVE
- [ ] Kjør minst én integrasjonstest LIVE

---

## Innlevering

- [ ] Opprett `README.md` med:
    - [ ] Kort oversikt over løsningen
    - [ ] Instruksjoner for å kjøre koden
    - [ ] Dokumentasjon av KI-bruk (prompter og svar)
- [ ] Eventuell ekstra dokumentasjon (diagrammer, tabeller, CSV)
- [ ] Videofil
- [ ] Pakk alt i `eksamen_emne6_<navn>.zip`

---

**Frist:** 12. desember 2025