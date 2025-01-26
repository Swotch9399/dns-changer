window.onload = function() {
    var userAgent = navigator.userAgent.toLowerCase();
    
    if (!/windows/i.test(userAgent)) {
        window.location.href = "notsupport.html";
    }

    if (window.innerWidth <= 800) {
        window.location.href = "notsupport.html";
    }
}

document.addEventListener('DOMContentLoaded', () => {
    const faqItems = document.querySelectorAll('.faq-item');

    faqItems.forEach(item => {
        const question = item.querySelector('.faq-question');
        question.addEventListener('click', () => {
            if (item.classList.contains('open')) {
                item.classList.remove('open');
            } else {
                faqItems.forEach(i => i.classList.remove('open'));
                item.classList.add('open');
            }
        });
    });
});