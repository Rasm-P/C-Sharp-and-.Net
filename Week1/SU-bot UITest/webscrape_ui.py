
import bs4
from time import sleep
from selenium import webdriver
from selenium.webdriver.common.keys import Keys


base_url = 'https://dtu-archibot-bot-channel-web-test.azurewebsites.net/'
browser = webdriver.Firefox()


def test_subot_dialog():
    browser.get(base_url)
    browser.implicitly_wait(3)

    search_field = browser.find_element_by_xpath("/html/body/div/div[2]/div/div[2]/div[2]/form/input")
    search_field.send_keys("hej")
    search_field.submit()
    search_field.send_keys(Keys.ENTER)

    sleep(sleep_time)