# Jonas' Portfolio & Learning Journey - AI Agent Instructions

## Project Overview
This is a multi-page personal portfolio and learning showcase built with Bootstrap 5.3.8. The site documents Jonas' web development learning journey with a project collection and personal information pages.

## Architecture & Structure
- **Multi-page application**: Separate pages for different sections
  - `index.html` - Home/landing page
  - `about.html` - About Jonas & learning journey
  - `websites.html` - School projects accordion collection
  - Future: CV, Contact, Blog, Skills pages
- **Minimal custom CSS**: [css/main.css](../css/main.css) provides theme colors
- **Bootstrap-first approach**: Bootstrap 5.3.8 for all layouts and components
- **Bootstrap Icons**: Used throughout for visual accents
- **Static assets**: Project preview images in `img/` directory

## Key Pages & Content

### index.html (Home)
- Welcome/landing page for visitors
- Navigation to other sections

### about.html (About Jonas)
- Personal introduction
- Learning journey overview
- Skills/badges
- Call-to-action buttons
- Responsive photo section

### websites.html (Project Collection)
- Accordion layout showcasing school projects
- Project categories: School Projects, Self-study (Zelfstudie), Exam Prep
- Each project has preview image, description, and external link

## UI Pattern - Accordion Cards
The project collection uses a consistent pattern for each project entry:

```html
<div class="accordion-item">
  <h2 class="accordion-header">
    <button class="accordion-button collapsed" data-bs-toggle="collapse" 
            data-bs-target="#flush-collapseID">
      <span class="d-block fw-semibold mb-1">Category:</span>
      <span class="d-block">Title</span>
    </button>
  </h2>
  <div id="flush-collapseID" class="accordion-collapse collapse">
    <div class="accordion-body p-0 d-flex justify-content-center mt-3">
     Navigation**: Sticky navbar with links to Home, About, Projects
2. **Two-line accordion headers**: Use `<span class="d-block">` to stack category and title
3. **Unique collapse IDs**: Sequential naming (`flush-collapseOne`, `flush-collapseTwo`, etc.)
4. **16:9 aspect ratio**: All preview images use `ratio ratio-16x9` container
5. **External links**: School projects link to external jonastrap.be hosting
6. **Bootstrap Icons**: Icons for visual enhancement (bi bi-box-arrow-up-right, bi bi-person-circle)
7. **Language**: Dutch throughout (UI text, descriptions, headings)
8. **Theme colors**: Currently uses light theme with Bootstrap primary/secondary colors
          <p class="card-text flex-grow-1 mb-3 text-muted">Description</p>
          <a href="URL" class="btn btn-primary mt-auto align-self-start">
            Bekijk Project <i class="bi bi-box-arrow-up-right"></i>
          </a>
        </div>
      </div>
    </div>
  </div>
</div>
```

## Key Conventions
1. **Two-line accordion headers**: Use `<span class="d-block">` to stack category and title
2. **Unique collapse IDs**: Sequential naming (`flush-collapseOne`, `flush-collapseTwo`, etc.)
3. **16:9 aspect ratio**: All preview images use `ratio ratio-16x9` container
4. **External links**: All project links point to `jonastrap.be` subdirectories
5. **Bootstrap Icons**: Use `bi bi-box-arrow-up-right` for external link indicator
6. About Jonas
- **Background**: Web development student at Thomas More Kempen
- **Experience**: Starting from HTML/CSS, now learning Bootstrap and responsive design
- **Goal**: Build a strong foundation in web development, eventually learn JavaScript and frameworks
- **Learning approach**: School projects + self-study exercises + exam preparation
- **Portfolio purpose**: Showcase learning journey and document skill progressionignments
- **Self-study** (`Zelfstudie 1-5`): Practice exercises (Tesla, Bordspel, Olympics, Klei, Tour de France)
- **Exam Prep** (`Examen Jan 2026`): Recent exam exercises

## External Dependencies
- Bootstrap 5.3.8 CSS & JS (from CDN with SRI integrity)
- Bootstrap Icons 1.11.3 (from CDN)
- No build tools or package managers required

##Open any `.html` file in browser to preview
- Multi-page navigation via navbar links
- School projects link to live hosted versions on `jonastrap.be`

## When Adding New Projects (to websites.html)
1. Increment the collapse ID number (`flush-collapseNine` → `flush-collapseTen`)
2. Match `aria-controls` and `data-bs-target` attributes to the new ID
3. Add corresponding preview image to `img/` directory
4. Maintain the two-line header pattern with category and title
5. Keep Dutch language for consistency
6. Maintain accordion structure with proper Bootstrap classes

## When Adding New Pages
1. Create new `.html` file with full structure (head, navbar, content, scripts)
2. Copy navbar from existing page to maintain consistency
3. Update navbar links to include new page
4. Follow responsive grid patterns (use `col-lg-*` classes)
5. Maintain Bootstrap 5.3.8 and Bootstrap Icons CDN linksirectory
4. Maintain the two-line header pattern with category and title
5. Keep Dutch language for consistency
