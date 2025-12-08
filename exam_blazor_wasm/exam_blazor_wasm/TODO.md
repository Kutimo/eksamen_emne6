# Eksamen Emne 6 - Software Design - TODO

## Oppgave 1: Blazor WebAssembly App

### Grunnleggende oppsett
- [x] Opprett nytt Blazor WebAssembly-prosjekt (standalone, ingen backend)
- [ ] Sett opp HttpClient med Dependency Injection
- [ ] Opprett service for Random User API-kommunikasjon

### Funksjonelle krav

**1. Hente og vise brukere**
- [ ] Hent minst 10 brukere fra `https://randomuser.me/api/?results=10`
- [ ] Vis brukere i liste/tabell/kort-format
- [ ] For hver bruker, vis:
    - [ ] Profilbilde (thumbnail/medium/large)
    - [ ] Fullt navn
    - [ ] Kjønn
    - [ ] Land
    - [ ] E-post

**2. Detaljvisning**
- [ ] Implementer klikk-handling på bruker i lista
- [ ] Vis detaljside med:
    - [ ] Større bilde (medium/large)
    - [ ] Fullt navn
    - [ ] Alder
    - [ ] Kjønn
    - [ ] Adresse (by og land)
    - [ ] E-post
    - [ ] Telefonnummer

**3. Filtrering/søk (minst én)**
- [ ] Filtrering på kjønn (male/female/alle)
- [ ] Filtrering på land
- [ ] Søk etter navn

**4. Oppdater brukere**
- [ ] "Hent nye brukere"-knapp
- [ ] Nytt API-kall ved klikk
- [ ] Oppdater listevisning

**5. Feilhåndtering**
- [ ] Håndter lastetilstand (loading spinner/melding)
- [ ] Håndter feil ved API-kall (feilmelding til bruker)


Annet: 
- [ ] favicon
- [ ] fix ugly errors
- [] make css lib with reusable code
- [] accesibility checks
- 
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